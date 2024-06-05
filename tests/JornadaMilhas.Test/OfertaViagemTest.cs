using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestandoOfertaValida()
        {
            //cen�rio
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024, 6, 6), new DateTime(2024, 7, 6));
            double preco = 100.0;
            var validacao = true;

            //a��o
            OfertaViagem oferta = new OfertaViagem(rota,periodo,preco);
            
            //valida��o
            Assert.Equal(validacao, oferta.EhValido);
        }
        [Fact]
        public void TestandocomRotaNula()
        {
            //cen�rio
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 6, 6), new DateTime(2024, 7, 6));
            double preco = 100.0;
            var validacao = true;

            //a��o
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //valida��o
            Assert.Contains("A oferta de viagem n�o possui rota ou per�odo v�lidos.", oferta.Erros.Sumario);
            Assert.False(oferta.EhValido);
        }
    }
}