import { Route } from '@angular/router';
import { LauncherPage } from './Pages/LauncherPage/launcher.page';
import { PersonalPage } from './Pages/PersonalPage/personal.page';
import { ProfessionalPage } from './Pages/ProfessionalPage/professional.page';
import { PageNotFoundComponent } from './Pages/ErrorPages/pageNotFound.page';

export const appRoutes: Route[] = [    
    { path: 'launcher', component: LauncherPage },
    { path: 'professionalPage', component: ProfessionalPage },
    { path: 'personalPage', component: PersonalPage },
    { path: '', redirectTo: '/launcher', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent},
];