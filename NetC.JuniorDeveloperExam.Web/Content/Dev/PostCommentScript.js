$(function () {
    
  
  
});
var CommingCommentIdFromReplay = 0;
    $("#btnSubmit").click(function () {
        var Name = $("#Name").val();
        var message = $("#Message").val();
        var emailAddress = $("#EmailAddress").val();
        var PostId = $("#PostId").val();
        
        $.ajax({
            method: "POST",
            url: "/Post/AddComment",
            data: { Name: Name, message: message, emailAddress: emailAddress, PostId: PostId}
        })
            .done(function (msg) {
                $('#myModal').modal('toggle');
            });
    });


$("#BtnModal").click(function () {

    location.reload();
});


$("#btnReplay").click(function () {
    var Name = $("#NameReplay").val();
    var message = $("#MessageReplay").val();
    var emailAddress = $("#EmailAddressReplay").val();
    var PostId = $("#PostId").val();
    var CommentId = CommingCommentIdFromReplay

    $.ajax({
        method: "POST",
        url: "/Post/AddReplay",
        data: { Name: Name, message: message, emailAddress: emailAddress, PostId: PostId, CommentId: CommentId}
    })
        .done(function (msg) {
    location.reload();

        });
});





function Replay(CId) {
    CommingCommentIdFromReplay = CId;
    $('#ReplayModal').modal('toggle');

}