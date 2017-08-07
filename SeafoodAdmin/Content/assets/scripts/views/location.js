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
                var option ={
                    controller:'Location',
                    action:'Approve',
                    data:{id:locationId},
                    callback:function(response){
                        if(response.Code == ResponseCode.Success)
                        {
                            library_sysmess.info(response.Message);
                        }
                        else if(response.Code == ResponseCode.Error)
                        {
                            library_sysmess.error(response.Message);
                        }
                        else
                        {
                            library_sysmess.warning(response.Message);
                        }
                    }
                };
                library_sysrequest.send(option);
            });
        });
    }
};