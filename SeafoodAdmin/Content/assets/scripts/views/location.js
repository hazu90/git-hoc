var location_index = {
    init: function () {
        $(document).ready(function () {
            location_index.register_grid_event();
        });
    },
    register_grid_event:function(){
        var tbl = $('#table-unappove-location');
        $('a[name=approve]',tbl).each(function(){
            $(this).off('click').on('click', function () {
                var locationId = $(this).data('locationId');

            });
        });
    }
};