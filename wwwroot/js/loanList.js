var initialData = [];

var AppViewModel = function(items) {
    var self = this;
    self.items = ko.observableArray(items);

    function getLoanList() {
        return window.fetch('/api/loans',{method:'GET'})
            .then(response=> response.json())
            .then(data=> {
                data.forEach((loan)=> {
                    self.items.push(loan);
                })
            })
    }

    getLoanList();
};

ko.applyBindings(new AppViewModel(initialData));
