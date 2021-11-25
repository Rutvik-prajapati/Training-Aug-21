var UsersUtils;
(function (UsersUtils) {
    var Parent = /** @class */ (function () {
        function Parent() {
        }
        Parent.prototype.setName = function (name) {
            return this.name = name;
        };
        return Parent;
    }());
    UsersUtils.Parent = Parent;
})(UsersUtils || (UsersUtils = {}));
