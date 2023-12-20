Feature: Gerenciar Aluno

  Scenario: Adicionar Aluno
    Given o usuário está na página de adição de alunos
    When o usuário preenche o formulário corretamente
    And clica no botão "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
