using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProff.Steps
{
    using TechTalk.SpecFlow;

    [Binding]
    public class AvaliacaoSteps
    {
        [Given("o usuário está na página de adição de avaliações")]
        public void GivenTheUserIsOnTheAddEvaluationPage()
        {
            // Implemente a navegação para a página de adição de avaliações aqui
        }

        [When("o usuário preenche o formulário corretamente")]
        public void WhenTheUserFillsInTheFormCorrectly()
        {
            // Implemente o preenchimento do formulário corretamente aqui
        }

        [When("clica no botão \"Adicionar\"")]
        public void WhenClicksTheAddButton()
        {
            // Implemente a ação de clicar no botão "Adicionar" aqui
        }

        [Then("o sistema exibe uma mensagem de sucesso")]
        public void ThenTheSystemDisplaysASuccessMessage()
        {
            // Implemente a verificação da mensagem de sucesso aqui
        }
    }

}
