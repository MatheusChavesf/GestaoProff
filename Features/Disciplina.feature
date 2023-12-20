Feature: Gerenciar Disciplina

  Scenario: Adicionar Disciplina
    Given o usuário está na página de adição de disciplinas
    When o usuário preenche o formulário corretamente
    And clica no botão "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
