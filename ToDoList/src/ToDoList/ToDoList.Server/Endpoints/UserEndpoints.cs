using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ToDoList.Bll.DTOs;
using ToDoList.Bll.Services;
using ToDoList.Dal.Entity;

namespace ToDoList.Server.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        var userGroup = app.MapGroup("/api/admin")
            .RequireAuthorization()       // Require [Authorize] globally for this group
            .WithTags("User Management"); // Swagger section name

        // Delete User - requires Admin or SuperAdmin role
        userGroup.MapDelete("/{userId}", [Authorize(Roles = "Admin,SuperAdmin")]
        async (long userId, HttpContext httpContext, IUserService userService) =>
            {
                var userIdFromToken = httpContext.User.FindFirst("UserId")?.Value;
                if(long.Parse(userIdFromToken) == userId)
                {
                    throw new Exception("It is not allowed to delete yourself");
                }

                var role = httpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                await userService.DeleteUserByIdAsync(userId, role);
                return Results.Ok();
            })
            .WithName("DeleteUser")
            .Produces(200)
            .Produces(404);


        userGroup.MapPut("/update-role", [Authorize(Roles = "SuperAdmin")]
        async ([FromQuery] long userId, UserRoleDto userRoleDto, IUserService userService) =>
            {
                await userService.UpdateUserRoleAsync(userId, userRoleDto);
                return Results.Ok();
            })
            .WithName("UpdateUserRole");


        userGroup.MapGet("/get-users", [Authorize(Roles = "Admin,SuperAdmin")]
        async (HttpContext httpContext, IUserService userService) =>
        {
            var role = httpContext.User.FindFirst(ClaimTypes.Role)?.Value;
            var usersDto = await userService.GetAllUsersAsync(role);
            return usersDto;
        })
            .WithName("GetAllUsers");
    }
}
