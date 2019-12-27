 //$('#example').DataTable({
    //    ajax: "",
    //    deferRender: true,
    //    scrollY: 200,
    //    scrollCollapse: true,
    //    scroller: true
    //});
   
$(document).ready(function () {
    //$("#example").DataTable({
    //    "processing": true,
    //    "serverSide": true,
    //    "ajax": {
    //        "url": "Ration/GetData",
    //        "type": "POST"
    //    },
    //    "columns": [
    //        { "data": "PacketId" },
    //        { "data": "PacketContent" },
    //        { "data": "Quantity" },
    //        { "data": "ExpiryDate" },
    //        { "data": "Calories" }          
    //    ]
    //});

    $('#example').DataTable({
       // "ajax": "data/objects.txt",
        "columns": [
            { "data": "name" },
            { "data": "position" },
            { "data": "office" },
            { "data": "extn" },
            { "data": "start_date" },
            { "data": "salary" }
        ]
    });
      
    });

 