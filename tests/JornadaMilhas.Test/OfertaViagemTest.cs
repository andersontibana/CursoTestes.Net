using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestandoOfertaValida()
        {
            //cenário
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024, 6, 6), new DateTime(2024, 7, 6));
            double preco = 100.0;
            var validacao = true;

            //ação
            OfertaViagem oferta = new OfertaViagem(rota,periodo,preco);
            
            //validação
            Assert.Equal(validacao, oferta.EhValido);
        }
        [Fact]
        public void TestandocomRotaNula()
        {
            //cenário
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 6, 6), new DateTime(2024, 7, 6));
            double preco = 100.0;
            var validacao = true;

            //ação
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //validação
            Assert.Contains("A oferta de viagem não possui rota ou período válidos.", oferta.Erros.Sumario);
            Assert.False(oferta.EhValido);
        }
    }
}