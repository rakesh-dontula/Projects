module("Calculator Tests", {
    setup: function () {
},     
teardown: function () {     
} 
}); 
  
test("Sum", function () { 
    // Arrange 
    var calculator = new Calculator(); 
    // Act 
    var sum = calculator.sum(2, 3); 
    // Assert 
    equal(5, sum); 
});