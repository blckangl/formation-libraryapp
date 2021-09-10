// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function deleteBook (id){
	console.log(id);
		fetch("/livre/"+id,{
	  method: 'DELETE',
	})
			.then((res) => {
				console.log(res);
				if (res.status = 200) {
					window.location.reload();
                }
	  });
}
