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
    Img1: string;
    Img2: string;
    Img3: string;
    Img4: string;
}