import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { ProfileComponent } from './profile/profile.component';
import { RecipeAdminComponent } from './recipe-admin/recipe-admin.component';
import { RecipeUserComponent } from './recipe-user/recipe-user.component';
import { AddRecipeComponent } from './add-recipe/add-recipe.component';
import { ForkRecipeComponent } from './fork-recipe/fork-recipe.component';
import { authInterceptorProviders } from './_helpers/auth.interceptor';
import { MatchPasswordDirective } from './_directives/match-password.directive';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    ProfileComponent,
    RecipeAdminComponent,
    RecipeUserComponent,
    AddRecipeComponent,
    ForkRecipeComponent,
    MatchPasswordDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [authInterceptorProviders],
  bootstrap: [AppComponent]
})
export class AppModule { }
