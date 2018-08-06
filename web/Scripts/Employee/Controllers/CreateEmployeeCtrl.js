(function() {
    var CreateEmployeeCtrl = function($scope, $http, $location) {
        $scope.employee = new Employee();

        $scope.create = function() {
            $http.post('/employeeExample/create', $scope.employee).then(function() {
                window.location = window.location.origin + window.location.pathname;
            });
            
        };
    };

    angular.module('EmployeeApp').controller("CreateEmployeeCtrl", ["$scope", "$http", "$location", CreateEmployeeCtrl]);
})();