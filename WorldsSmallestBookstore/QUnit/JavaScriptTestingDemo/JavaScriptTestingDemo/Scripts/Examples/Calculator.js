var Calculator = function () {
    this.sum = function (num1, num2)
    {
        if (num1 == undefined || num2 == undefined) {
            throw "Invalid argument";
        }
        return num1 + num2;
    }
};


