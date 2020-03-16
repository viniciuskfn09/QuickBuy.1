import { Component } from "@angular/core"

@Component({
  selector: "produto",
  template: "<html><body>{{ obterNome() }}<body></html>",

})

export class ProdutoComponent {   //export - uttilizado para q se possa ser utilizada para outros modulos.
                                    //nome das classes comecando com maiuscula por conta da convencao PascalCase.
   public nome: string;
   public liberadoParaVenda: boolean;

   public obterNome(): string {
     return "Samsung";
   }




}
