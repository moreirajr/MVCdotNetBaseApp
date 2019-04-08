import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.routing.module';
import { FormsModule } from '@angular/forms';
import { FormularioModule } from './formularios/formulario.module';
import { FormularioService } from './formularios/formulario.service';


@NgModule({
  declarations: [
    AppComponent,
  ],
  exports: [

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    FormularioModule
  ],
  providers: [FormularioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
