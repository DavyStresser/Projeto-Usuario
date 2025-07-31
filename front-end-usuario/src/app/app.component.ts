import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface Usuario {
  id_whatsapp: number;
  nome: string;
  celular: string;
  st_ativo: number;
  dt_cadastro: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  usuarios: Usuario[] = [];
  usuario: Partial<Usuario> = {};
  editando: boolean = false;

  private apiUrl = 'https://localhost:5001/api/Whatsapp';

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.listarUsuarios();
  }

  listarUsuarios(): void {
    this.http.get<Usuario[]>(`${this.apiUrl}/Listar`)
      .subscribe(res => this.usuarios = res);
  }

  salvarUsuario(): void {
    if (this.editando && this.usuario.id_whatsapp) {
      this.http.put(`${this.apiUrl}/Alterar`, this.usuario)
        .subscribe(() => {
          this.resetarFormulario();
          this.listarUsuarios();
        });
    } else {
      this.http.post(`${this.apiUrl}/Inserir`, this.usuario)
        .subscribe(() => {
          this.resetarFormulario();
          this.listarUsuarios();
        });
    }
  }

  editarUsuario(usuario: Usuario): void {
    this.usuario = { ...usuario };
    this.editando = true;
  }

  excluirUsuario(id: number): void {
    this.http.delete(`${this.apiUrl}/Excluir/${id}`)
      .subscribe(() => this.listarUsuarios());
  }

  resetarFormulario(): void {
    this.usuario = {};
    this.editando = false;
  }
}
