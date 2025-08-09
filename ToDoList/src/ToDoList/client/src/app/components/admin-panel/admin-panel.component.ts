import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { UserGetModel } from '../../services/models/user-get.model';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { UserRoleModel } from '../../services/models/user-role.model';

@Component({
  selector: 'app-admin-panel',
  standalone: false,
  templateUrl: './admin-panel.component.html',
  styleUrls: ['./admin-panel.component.css']
})
export class AdminPanelComponent implements OnInit {

  public displayedColumns: string[] = ['userId', 'firstName', 'lastName', 'userName', 'email', 'phoneNumber', 'role'];
  public users: UserGetModel[] = [];
  public UserRoleModel = UserRoleModel;
  public selectedRole: UserRoleModel = UserRoleModel.User;
  public showDeleteModal = false;
  public showSetRoleModal = false;
  public userToDelete: UserGetModel | null = null;
  public userToSetRole: UserGetModel | null = null;
  public roleOptions = [
    { value: UserRoleModel.User, label: 'User' },
    { value: UserRoleModel.Admin, label: 'Admin' },
    { value: UserRoleModel.SuperAdmin, label: 'Super Admin' }
  ];

  constructor(
    private userService: UserService,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService
  ) { }

  ngOnInit(): void {
    this.loadUsers();
  }


  public openSetRoleModal(user: UserGetModel): void {
    this.userToSetRole = user;
    this.showSetRoleModal = true;
  }

  public cancelSetRoleModal(): void {
    this.showSetRoleModal = false;
    this.userToDelete = null;
  }

  public setRole(): void {
    if (!this.userToSetRole) return;
    this.userToSetRole.role = this.selectedRole;
    this.spinner.show();
    this.userService.setRole(this.userToSetRole.userId, this.userToSetRole.role).subscribe({
      next: () => {
        this.spinner.hide();
        this.toastr.success('Role updated successfully!', 'Success');
        this.loadUsers();
        this.cancelSetRoleModal();
      },
      error: (err) => {
        this.spinner.hide();
        this.toastr.error('Failed to update role!', 'Error');
        this.cancelSetRoleModal();
      }
    });
  }

  public loadUsers(): void {
    this.spinner.show();
    this.userService.getAllUsers().subscribe({
      next: (data) => {
        this.users = data;
        this.spinner.hide();
      },
      error: (error) => {
        console.error('Failed to load users:', error);
        this.spinner.hide();
      }
    });
  }

  public deleteUser(userId: number): void {
    this.spinner.show();
    this.userService.deleteUser(userId).subscribe({
      next: () => {
        this.spinner.hide();
        this.loadUsers();
      },
      error: (error) => {
        console.error('Failed to delete user:', error);
        this.spinner.hide();
      }
    });
  }



  public openDeleteModal(user: UserGetModel): void {
    this.userToDelete = user;
    this.showDeleteModal = true;
  }

  public cancelDelete(): void {
    this.showDeleteModal = false;
    this.userToDelete = null;
  }

  public confirmDelete(): void {
    if (!this.userToDelete) return;

    this.spinner.show();
    this.userService.deleteUser(this.userToDelete.userId).subscribe({
      next: () => {
        this.spinner.hide();
        this.toastr.success('Deleted successfully!', 'Success');
        this.loadUsers();
        this.cancelDelete();
      },
      error: (err) => {
        this.spinner.hide();
        this.toastr.error('Delete failed!', 'Error');
        this.cancelDelete();
      }
    });
  }
}
