Feature: Gerenciar Nota

  Scenario: Adicionar Nota
    Given o usuário está na página de adição de notas
    When o usuário preenche o formulário corretamente
    And clica no botão "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
