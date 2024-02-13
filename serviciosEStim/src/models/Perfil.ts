import { Juego } from "./Juego.js";

export interface Perfil {
    Id: string;
    NombreUsuario: string;
    Contrasenya: string;
    Descripcion?: string;
    Estado: Estado;
    Region: string;
    JuegosAdquiridos: Juego[];
    ImagenB64?: string;
}

export enum Estado {
    Desconectado,
    Conectado,
    Ausente
}