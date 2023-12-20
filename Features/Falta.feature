Feature: Gerenciar Falta

  Scenario: Adicionar Falta
    Given o usuário está na página de adição de faltas
    When o usuário preenche o formulário corretamente
    And clica no botão "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
