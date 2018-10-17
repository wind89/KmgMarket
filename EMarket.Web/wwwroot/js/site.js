var categoryHelper = new function () {
    this.addProperty = function () {
        $('#properties').append(`<tr><td><span>Свойство: </span><input type="text" name="Properties"/></td></tr>`);
    }
}

var productHelper = new function () {
    this.onChangeCategory = function () {
        var categoryId = $('#categoriesDropdown').val();
        $parametersContainer = $('#parametersContainer');
        $.ajax({
            url: `/category/properties?id=${categoryId}`,
            method: "GET"
        }).done(function (results) {
            $parametersContainer.html('');
            $.each(results, function (index, value) {
                $parametersContainer.append(`<div class="form-group mb-2" style="padding-right: 15px;">
                                                    <label for="property${value.id}">${value.name}: <label>
                                                    <input type="text" class="form-control" id="property${value.id}" name="Properties[${value.id}]"/>
                                                </div>
                                            `);
            });
            }); 
    }

    this.search = function () {
        $form = $('#formSearchProduct');
        $.ajax({
            url: '/product/search',
            method: "POST",
            data: $form.serialize()
        }).done(function (results) {
            $('#results').html('');
            $.each(results, function (index, value) {
                $('#results').append(`<div class="row product-item">
                                        <div class="col-sm-2"><img src="/images/nophoto.jpg" width="100%"/></div>
                                        <div class="col-sm-10">
                                            <div><label>Наименование: </label><a href="/product/detail?id=${value.id}">${value.name}</a></div>
                                            <div><label>Цена: </label>${value.price}</div>
                                            <div><label>Описание: </label>${value.description}</div>
                                        </div>
                               </div>`)
            });
            return false;
            })
            .error(function () {
                alert('error');
            });
        return false;
    }
}

$(document).ready(function () {
    productHelper.search();
});