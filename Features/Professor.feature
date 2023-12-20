Feature: Gerenciar Professor

  Scenario: Adicionar Professor
    Given o usuário está na página de adição de professores
    When o usuário preenche o formulário corretamente
    And clica no botão "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
