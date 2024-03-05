class Perfil {
    id: string;
    nombreUsuario: string;
    contrasenya: string;
    descripcion: string;
    estado: Estado;
    region: string;
    juegosAdquiridos: Juego[];
    imagenB64: string;
}

enum Estado {
    Desconectado,
    Conectado,
    Ausente
}