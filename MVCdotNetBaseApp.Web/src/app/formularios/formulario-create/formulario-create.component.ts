import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroupDirective, NgForm, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
import { Formulario } from '../formulario';
import { FormularioService } from '../formulario.service';

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

  constructor(private formularioService: FormularioService) {

  }

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

  formulario: Formulario;

  nomeFormControl = new FormControl('', [Validators.required]);
  dataInicioFormControl = new FormControl('');
  dataFimFormControl = new FormControl('');
  descricaoFormControl = new FormControl('');
  tipoCampoFormControl = new FormControl('');
  tipoValorFormControl = new FormControl('');

  matcher = new FormularioErrorStateMatcher();

  ngOnInit() {
  }

  salvar() {

    this.formulario = {
      Id: null,
      Nome: `${this.nomeFormControl.value}`,
      DataInicio: null,
      DataFim: null,
      Campos: [
        {
          Id: null,
          Descricao: `${this.descricaoFormControl.value}`,
          Tipo: this.tipoCampoFormControl.value,
          TipoValor: this.tipoValorFormControl.value
        }
      ]
    };

    return this.formularioService.save(this.formulario).subscribe(result => { });
  }

  getFormularios() {
    return this.formularioService.getFormularios().subscribe(result => { });
  }

}

export class FormularioErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
