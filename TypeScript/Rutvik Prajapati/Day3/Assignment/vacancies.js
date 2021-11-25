"use strict";
exports.__esModule = true;
exports.Vacancies = void 0;
var Vacancies = /** @class */ (function () {
    function Vacancies() {
    }
    Vacancies.prototype.setNumberOfVacancies = function (seat) {
        this.seats = seat;
    };
    Vacancies.prototype.getVacanciesSeat = function () {
        console.log(this.seats);
    };
    return Vacancies;
}());
exports.Vacancies = Vacancies;
