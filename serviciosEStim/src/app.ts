//Librerias
import express from 'express';
import { Juego } from './models/Juego.js';
import { Perfil } from './models/Perfil.js';
import * as fs from 'fs';

let GTA_Portada = fs.readFileSync('./src/images/GTA_Portada.txt', 'utf8');
let GTA_Img1 = fs.readFileSync('./src/images/GTA1.txt', 'utf8');
let GTA_Img2 = fs.readFileSync('./src/images/GTA2.txt', 'utf8');
let GTA_Img3 = fs.readFileSync('./src/images/GTA3.txt', 'utf8');
let GTA_Img4 = fs.readFileSync('./src/images/GTA4.txt', 'utf8');

let COD_Portada = fs.readFileSync('./src/images/COD_Portada.txt', 'utf8');
let COD_Img1 = fs.readFileSync('./src/images/COD1.txt', 'utf8');
let COD_Img2 = fs.readFileSync('./src/images/COD2.txt', 'utf8');
let COD_Img3 = fs.readFileSync('./src/images/COD3.txt', 'utf8');
let COD_Img4 = fs.readFileSync('./src/images/COD4.txt', 'utf8');

let AC_Portada = fs.readFileSync('./src/images/AC_Portada.txt', 'utf8');
let AC_Img1 = fs.readFileSync('./src/images/AC1.txt', 'utf8');
let AC_Img2 = fs.readFileSync('./src/images/AC2.txt', 'utf8');
let AC_Img3 = fs.readFileSync('./src/images/AC3.txt', 'utf8');
let AC_Img4 = fs.readFileSync('./src/images/AC4.txt', 'utf8');

let TLOU_Portada = fs.readFileSync('./src/images/TLOU_Portada.txt', 'utf8');
let TLOU_Img1 = fs.readFileSync('./src/images/TLOU_1.txt', 'utf8');
let TLOU_Img2 = fs.readFileSync('./src/images/TLOU_2.txt', 'utf8');
let TLOU_Img3 = fs.readFileSync('./src/images/TLOU_3.txt', 'utf8');
let TLOU_Img4 = fs.readFileSync('./src/images/TLOU_4.txt', 'utf8');

const juego1: Juego = {
    Id: "1",
    Nombre: "Assassins Creed Valhalla",
    Descripcion: "Juego de aventuras en mundo abierto en la época vikinga.",
    Precio: 69,
    FechaLanzamiento: new Date(),
    Desarrollador: "Ubisoft",
    Editor: "Ubisoft Montreal",
    Generos: ["Acción", "Aventura", "Mundo Abierto", "Sigilo"],
    PortadaB64: AC_Portada,
    Img1: AC_Img1,
    Img2: AC_Img2,
    Img3: AC_Img3,
    Img4: AC_Img4
}

const juego2: Juego = {
    Id: "2",
    Nombre: "The Last Of Us",
    Descripcion: "Juego de supervivencia en un mundo post-apocalíptico.",
    Precio: 19.99,
    FechaLanzamiento: new Date(),
    Desarrollador: "Naughty Dog",
    Editor: "Naughty Dog",
    Generos: ["Terror", "Acción", "Aventura", "Supervivencia"],
    PortadaB64: TLOU_Portada,
    Img1: TLOU_Img1,
    Img2: TLOU_Img2,
    Img3: TLOU_Img3,
    Img4: TLOU_Img4
    }

const juego3: Juego = {
    Id: "3",
    Nombre: "Call of Duty: Black Ops 4",
    Descripcion: "El mejor juego de la saga, con un modo battle royale renovado.",
    Precio: 39.95,
    FechaLanzamiento: new Date(),
    Desarrollador: "Activision",
    Editor: "Treyarch",
    Generos: ["Shooter", "Acción"],
    PortadaB64: COD_Portada,
    Img1: COD_Img1,
    Img2: COD_Img2,
    Img3: COD_Img3,
    Img4: COD_Img4
}

const juego4: Juego = {
    Id: "4",
    Nombre: "GTA V",
    Descripcion: "Sandbox que se centra en la vida de tres criminales en la ciudad de San Andreas.",
    Precio: 59.95,
    FechaLanzamiento: new Date(),
    Desarrollador: "Rockstar Games",
    Editor: "Rockstar North",
    Generos: ["Acción", "SandBox", "Aventura"],
    PortadaB64: GTA_Portada,
    Img1: GTA_Img1,
    Img2: GTA_Img2,
    Img3: GTA_Img3,
    Img4: GTA_Img4
}

const perfil1: Perfil = {
    Id: '1',
    NombreUsuario: 'Paquito69',
    Contrasenya: 'Hola me llamo Paquito',
    Estado: "Conectado",
    Region: 'España',
    JuegosAdquiridos: [juego1, juego2]
}
const perfil2: Perfil = {
    Id: '2',
    NombreUsuario: 'Pepito420',
    Contrasenya: 'Hola me llamo Pepito',
    Estado: "Ausente",
    Region: 'Andorra',
    JuegosAdquiridos: [juego2, juego1]
}

let app = express();

// Carga de middleware y enrutadores
app.use(express.json());

//Servicios
app.get("/juegos", (_req, res) => {
    
    res.send([juego1, juego2, juego3, juego4])
});

//Servicios
app.get("/juegos/:id", (_req, res) => {
    res.send([juego1])
});

app.get("/perfiles", (_req, res) => {
    res.send([perfil1, perfil2])
});

app.get("/perfiles/:id", (_req, res) => {
    res.send([perfil2])
});

//Puesta en marcha
app.listen(8080);
console.log("Servicios iniciados");