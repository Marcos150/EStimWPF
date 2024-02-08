import { Juego } from "./Juego.js";

export interface Perfil {
    id: string;
    nombreUsuario: string;
    contrasenya: string;
    descripcion?: string;
    estado: Estado;
    region: string;
    juegosAdquiridos: Juego[];
    imagenB64?: string;
}

export enum Estado {
    Desconectado,
    Conectado,
    Ausente
}