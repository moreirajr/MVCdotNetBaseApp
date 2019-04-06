import { Component, OnInit, ViewChild } from '@angular/core';
import { Formulario } from '../formulario';
import { MatPaginator, MatTableDataSource } from '@angular/material';

@Component({
  selector: 'app-formulario-list',
  templateUrl: './formulario-list.component.html',
  styleUrls: ['./formulario-list.component.css']
})
export class FormularioListComponent implements OnInit {

  dataSource = new MatTableDataSource<Formulario>();
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor() { }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
  }

}
