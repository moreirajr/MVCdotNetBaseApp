export interface Formulario {
  Id: string,
  Nome: string,
  DataInicio: Date,
  DataFim: Date,
  Campos: Campo[],
}

export interface Campo {
  Id: string,
  Descricao: string,
  Tipo: number,
  TipoValor: number,
}
