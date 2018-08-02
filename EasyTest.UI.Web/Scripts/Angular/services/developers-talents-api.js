angular.module("easyTest").factory("developersTalentsApi", function ($http, globalValues) {
    return {
        getDevelopersTalents: function () {
            return $http.get(globalValues.easyTestApiUrl + "/api/developers-talents");
        },
        getDeveloperTalent: function (id) {
            return $http.get(globalValues.easyTestApiUrl + "/api/developers-talents/" + id);
        },
        putDeveloperTalent: function (developerTalent) {
            return $http.put(globalValues.easyTestApiUrl + "/api/developers-talents", developerTalent);
        },
        postDeveloperTalent: function (developerTalent) {
            return $http.post(globalValues.easyTestApiUrl + "/api/developers-talents", developerTalent);
        },
        deleteDeveloperTalent: function (id) {
            return $http.delete(globalValues.easyTestApiUrl + "/api/developers-talents/" + id);
        }
    };
});