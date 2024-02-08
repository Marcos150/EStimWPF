export interface Juego {
    id: string;
    nombre: string;
    descripcion?: string;
    precio: number;
    fechaLanzamiento: Date;
    desarrollador: string;
    editor?: string;
    generos?: string[];
    portadaB64?: string;
}