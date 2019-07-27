

/// <reference path="angular.min.js" />

var myapp = angular.module("myModule", [])
                   
                    .controller("mycontroller", function ($scope) {

                        var employees = [

                            { name: "Saikat", dateOfBirth: new Date("March 15,1998"), gender: 1, salary: 55000.78 },
                            { name: "Rabbi", dateOfBirth: new Date("July 15,1997"), gender: 2, salary: 85000 },
                            { name: "Rakib", dateOfBirth: new Date("June 15,1996"), gender: 1, salary: 65000 },
                            { name: "Sam", dateOfBirth: new Date("April 15,1996"), gender: 2, salary: 75000 }
                        ];

                        $scope.employees = employees;
                        $scope.sortColmn = "name";
                        $scope.reverseSort = false;
                        $scope.employeeVeiw = "ngInclude.html";


                        $scope.sortData = function (column) {
                            $scope.reverseSort = (column == $scope.sortColmn) ? !$scope.reverseSort : false;
                            $scope.sortColmn = column;
                        }


                        $scope.getSortClass = function (column) {
                            if ($scope.sortColmn == column) {
                                return $scope.reverseSort ? 'arrow-down' : 'arrow-up';
                            }
                        }

                        $scope.search = function(item){

                            if ($scope.searchTxt == undefined) {
                                return true;
                            }

                            if (item.name.toLowerCase().indexOf($scope.searchTxt.toLowerCase()) != -1)
                                return true;
                            
                            return false;

                        }
                    });