export interface Juego {
    Id: string;
    Nombre: string;
    Descripcion?: string;
    Precio: number;
    FechaLanzamiento: Date;
    Desarrollador: string;
    Editor?: string;
    Generos?: string[];
    PortadaB64?: string;
}