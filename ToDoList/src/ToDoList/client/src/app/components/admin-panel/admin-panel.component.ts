import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { UserGetModel } from '../../services/models/user-get.model';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-admin-panel',
  standalone: false,
  templateUrl: './admin-panel.component.html',
  styleUrls: ['./admin-panel.component.css']
})
export class AdminPanelComponent implements OnInit {

  public displayedColumns: string[] = ['userId', 'firstName', 'lastName', 'userName', 'email', 'phoneNumber', 'role'];
  public users: UserGetModel[] = [];

  constructor(
    private userService: UserService,
    private spinner: NgxSpinnerService
  ) {}

  ngOnInit(): void {
    this.loadUsers();
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
}
