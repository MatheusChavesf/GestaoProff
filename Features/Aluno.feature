Feature: Gerenciar Aluno

  Scenario: Adicionar Aluno
    Given o usu�rio est� na p�gina de adi��o de alunos
    When o usu�rio preenche o formul�rio corretamente
    And clica no bot�o "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
