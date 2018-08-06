(function() {
    var EmployeeListingCtrl = function($scope, $http) {
        $scope.employees = [];

        $http.get('/employeeExample/getEmployees').then(function (result) {
            if (result.data === null || result.data.Items === null)
                return;

            for (i = 0; i < result.data.Items.length; i++) {
                var employee = result.data.Items[i];
                $scope.employees.push(
                    new Employee(employee.Id, employee.FirstName, employee.LastName)
                    );
            }
        })
    };

    angular.module('EmployeeApp').controller("EmployeeListingCtrl", ["$scope", "$http", EmployeeListingCtrl]);
})();

function Employee(id, firstName, lastName) {
    this.id = id;
    this.firstName = firstName;
    this.lastName = lastName;
}
