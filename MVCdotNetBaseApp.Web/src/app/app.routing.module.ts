import { NgModule } from "@angular/core";
import { Routes, RouterModule } from '@angular/router';

import { FormularioCreateComponent } from './formularios/formulario-create/formulario-create.component';
import { FormularioListComponent } from './formularios/formulario-list/formulario-list.component';


const routes: Routes = [
  { path: 'Formulario/Create', component: FormularioCreateComponent },
  { path: 'Formulario', component: FormularioListComponent },
  { path: 'Formulario/Index', component: FormularioListComponent },
  //{ path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {

}
