using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProff.Steps
{
    using TechTalk.SpecFlow;

    [Binding]
    public class ProfessorSteps
    {
        [Given("o usuário está na página de adição de professores")]
        public void GivenTheUserIsOnTheAddProfessorPage()
        {
            // Implemente a navegação para a página de adição de professores aqui
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
