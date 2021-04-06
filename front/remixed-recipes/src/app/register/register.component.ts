import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})

export class RegisterComponent implements OnInit {
  form: any = {
    title: null,
    firstName: null,
    lastName: null,
    email: null,
    password: null,
    confirmPassword: null,
    acceptTerms: null 
  };
  isSuccessful = false;
  isSignUpFailed = false;
  errorMessage = '';

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
    {
      
    }
  }

  onSubmit(): void {
    const { title, firstName, lastName, email, password, confirmPassword, acceptTerms } = this.form;

    this.authService.register(title, firstName, lastName, email, password, confirmPassword, acceptTerms).subscribe(
      data => {
        console.log(data);
        this.isSuccessful = true;
        this.isSignUpFailed = false;
      },
      err => {
        this.errorMessage = err.error.message;
        this.isSignUpFailed = true;
      }
    );
  }

}

