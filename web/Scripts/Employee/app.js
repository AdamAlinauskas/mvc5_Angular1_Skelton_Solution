//
//new function () {
//
//    'use strict';
//
//   
//
    var app = angular.module('EmployeeApp', ['ngRoute', 'ngAnimate']);
//
//    // *** Configuration ***
//
    app.config([
        '$routeProvider', '$locationProvider',
        function ($routeProvider, $locationProvider) {

            $routeProvider.when('/create', {
                templateUrl: '/partials/Employee/Create.html', caseInsensitiveMatch: true
            }).when('/:id', {
                templateUrl: '/partials/Employee/edit.html'
            }).otherwise({
                templateUrl: '/partials/Employee/listing.html'
            });

            $locationProvider.html5Mode({
                enabled: false,
                requireBase: false
            });
        }
    ]);
//
//    //IE caching requests issue:
//    //http://stackoverflow.com/a/19771501/1312222
//
//    app.config(['$httpProvider', function ($httpProvider) {
//        //initialize get if not there
//        if (!$httpProvider.defaults.headers.get) {
//            $httpProvider.defaults.headers.get = {};
//        }
//
//        //disable IE ajax request caching
//        $httpProvider.defaults.headers.get['If-Modified-Since'] = 'Mon, 26 Jul 1997 05:00:00 GMT';
//        // extra
//        $httpProvider.defaults.headers.get['Cache-Control'] = 'no-cache';
//        $httpProvider.defaults.headers.get['Pragma'] = 'no-cache';
//    }]);
////
////    // ***Services*** //
////
////    app.service('membershipService', function () {
////
////        return {
////            selectedMemberships: [],
////            addRemoveSiteMembershipCallback: null
////        }
////    });
////
////    app.service('employeeTask', ['$http', '$q', function ($http, $q, loadingOverlayService) {
////        var canEdit = null;
////        var hasStartedToExecute = false;
////        var defferedItems = [];
////
////        return {
////            getCanEdit: function () {
////
////                if (canEdit == null) {
////                    var deferred = $q.defer();
////                    defferedItems.push(deferred);
////
////                    if (hasStartedToExecute === true)
////                        return deferred.promise;
////
////                    hasStartedToExecute = true;
////
////                    $http.get(window.employeeDetailURLs.canEdit)
////                        .then(function () {
////                            canEdit = true;
////                        },
////                            function () {
////                                canEdit = false;
////                            })
////                        .finally(function () {
////                            for (var i = 0; i < defferedItems.length; i++) {
////                                defferedItems[i].resolve(canEdit);
////                            }
////                        });
////
////                    return deferred.promise;
////
////                }
////
////                return $q.resolve(canEdit);
////            }
////        }
////    }]);
////
////    // *** Code for blasting the cache...this might need tweaking...
////
////    app.run(['$rootScope', '$templateCache', function ($rootScope, $templateCache) {
////        $rootScope.$on('$routeChangeStart', function (event, next, current) {
////            if (typeof (current) !== 'undefined') {
////                $templateCache.remove(current.templateUrl);
////            }
////        });
////    }]);
//}();
//
