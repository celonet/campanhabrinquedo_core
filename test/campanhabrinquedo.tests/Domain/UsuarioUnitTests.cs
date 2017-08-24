namespace campanhabrinquedo.tests
{       
    using campanhabrinquedo.domain.Entidades;
    using Xunit;

    public class UsuarioUnitTests
    {
        [Fact]
        public void NovoUsuario_DadoQueDadosEstaoCorretos_DeveIntanciarNovoUsuario()
        {
            var usuario = new Usuario("Fulano","fulano@detal.com","123456");
        }

        [Fact]
        public void NomeEValido_QuandoPassadoUmNomeValido_DeveRetornarVerdadeiro()
        {
            var usuario = new Usuario();
            Assert.Equal(true, usuario.NomeEValido("Fulano de Tal"));
        }

        [Fact]
        public void NomeEValido_QuandoPassadoUmNomeInvalido_DeveRetornarVerdadeiro()
        {
            var usuario = new Usuario();
            Assert.Equal(false, usuario.NomeEValido(null));
            Assert.Equal(false, usuario.NomeEValido("ABC"));
            Assert.Equal(false, usuario.NomeEValido(""));
        }

        [Fact]
        public void SenhaEValida_QuandoPassadoUmaSenhaInvalida_DeveRetornarVardadeiro()
        {
            var usuario = new Usuario();
            Assert.Equal(true, usuario.SenhaEValida("abc123"));
        }

        [Fact]
        public void SenhaEValida_QuandoPassadoUmaSenhaInvalida_DeveRetornarFalso()
        {
            var usuario = new Usuario();
            Assert.Equal(false, usuario.SenhaEValida("abc"));
            Assert.Equal(false, usuario.SenhaEValida(null));
            Assert.Equal(false, usuario.SenhaEValida(""));
        }

        [Fact]
        public void EmailEValido_QuandoPassadoUmEmailValido_DeveRetornarVerdadeiro()
        {
            var usuario = new Usuario();
            Assert.Equal(true, usuario.EmailEValido("fulano@detal.com"));
        }

        [Fact]
        public void EmailEValido_QuandoPassadoUmEmailInvalido_DeveRetornarFalso()
        {
            var usuario = new Usuario();
            Assert.Equal(false, usuario.EmailEValido("fulano.com"));
            Assert.Equal(false, usuario.EmailEValido(""));
            Assert.Equal(false, usuario.EmailEValido(null));
        }
    }
}