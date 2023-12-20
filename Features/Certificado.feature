Feature: Adicionar Certificado

  Scenario: Certificado válido
    Given the user is on the certificates page
    When the user fills in the form correctly
    And clicks the "Add" button
    Then the system displays a success message

  Scenario: Certificado inválido
    Given the user is on the certificates page
    When the user fills in the form incorrectly
    And clicks the "Add" button
    Then the system displays an error message
