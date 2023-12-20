Feature: Gerenciar Avaliação

  Scenario: Adicionar Avaliação
    Given o usuário está na página de adição de avaliações
    When o usuário preenche o formulário corretamente
    And clica no botão "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
