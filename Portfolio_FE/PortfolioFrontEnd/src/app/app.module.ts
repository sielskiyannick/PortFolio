// core modules
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { appRoutes } from './app.routes';
import { RouterModule } from '@angular/router';

// pages
import { LauncherPage } from './Pages/LauncherPage/launcher.page';
import { PersonalPage } from './Pages/PersonalPage/personal.page';
import { ProfessionalPage } from './Pages/ProfessionalPage/professional.page';
import { PageNotFoundComponent } from './Pages/ErrorPages/pageNotFound.page';

//components
import { TopNavigatorComponent } from './Components/Navigation/TopNavigator/topNavigator.page';

@NgModule({
  declarations: [ AppComponent, LauncherPage, PersonalPage, ProfessionalPage, PageNotFoundComponent, TopNavigatorComponent ],
  imports: [ BrowserModule, RouterModule.forRoot(appRoutes, {enableTracing: true}) ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
