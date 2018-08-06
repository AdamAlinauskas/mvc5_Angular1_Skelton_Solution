(function() {
    var EditEmployeeCtrl = function ($scope, $http, $routeParams) {
        var employeeId = $routeParams.id;
        $scope.employee = new Employee();

        $http.get('/employeeExample/edit/' + employeeId).then( function(result) {
            $scope.employee.id = result.data.Id;
            $scope.employee.firstName = result.data.FirstName;
            $scope.employee.lastName = result.data.LastName;
        });

        $scope.save = function() {
            $http.post('/employeeExample/edit', $scope.employee).then(function() {
                window.location = window.location.origin + window.location.pathname;
            });
        };
    };

    angular.module('EmployeeApp').controller("EditEmployeeCtrl", ["$scope", "$http", "$routeParams", EditEmployeeCtrl]);
})();