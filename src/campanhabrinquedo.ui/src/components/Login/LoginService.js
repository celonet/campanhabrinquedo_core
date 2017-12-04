export default class LoginService {
    constructor(resource) {
        this._resource = resource('/api/usuario/token');
    }

    logar(usuario) {
        return this._resource
            .post(usuario);
    }
}