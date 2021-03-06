export default class UsuarioService {

    constructor(resource) {
        this._resource = resource('usuario/token');
    }

    login(usuario) {
        return this._resource
            .save(usuario)
            .then(res => res.json(), err => {
                console.log(err)
                throw new Error("Não foi possivel verificar usuario.");
            });
    }
}