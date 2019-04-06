import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroupDirective, NgForm, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';

export interface TipoCampo {
  value: string;
  text: string;
}

export interface TipoValor {
  value: string;
  text: string;
}

@Component({
  selector: 'app-formulario-create',
  templateUrl: './formulario-create.component.html',
  styleUrls: ['./formulario-create.component.css']
})

export class FormularioCreateComponent implements OnInit {

  tiposCampo: TipoCampo[] = [
    { value: '1', text: 'TextBox' },
    { value: '2', text: 'Dropbox' },
    { value: '4', text: 'Radio' },
    { value: '8', text: 'Button' }
  ];

  tiposValor: TipoValor[] = [
    { value: '1', text: 'Texto' },
    { value: '2', text: 'Numérico' },
    { value: '4', text: 'Moeda' },
    { value: '8', text: 'Data' }
  ];

  nomeFormControl = new FormControl('', [Validators.required]);
  matcher = new FormularioErrorStateMatcher();

  ngOnInit() {
  }

}

export class FormularioErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
