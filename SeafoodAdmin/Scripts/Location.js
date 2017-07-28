var location_index = {
    init:function(){
        $(document).ready(function(){
            location_index.search();
        });
    },
    register_event:function(){
        var tblSearch = $('#tablRegisteredInvitee');
        $('#btnEdit',tblSearch).each(function(){
            $(this).off('click').on('click',function(){

            });
        });
        $('#btnApprove',tblSearch).each(function(){
            $(this).off('click').on('click',function(){
                var locationId = $(this).data('id');
                sys_call_ajax.call_json_type('Location','Appove',{id:locationId},null,
                                  function(response){
                                        
                                  }  );
            });
        });
    },
    search:function(){
        $.ajax({
            url: "/Location/Search",
            type: "GET",
            data: {},
            dataType: "html",
            async: true,
            beforeSend: function () { },
            error: function (jqXHR, textStatus, errorThrown) { },
            success: function (response) {
                $("#search-content-list",$('#SearchLocation')).html(response);
            },
            complete: function () {
            }
        });
    }
};