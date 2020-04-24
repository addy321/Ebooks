//生成table
function GenerateTable(DOM,JsonListDate,ListTitle){
	var tableHtml='<table class="table table-hover"><thead><tr>'
	for (index in ListTitle) {
		tableHtml+='<th>'+ListTitle[index]+'</th>'
	}
	tableHtml+='</tr></thead><tbody>'
	
	if(JsonListDate!=null){
		JsonListDate.forEach((data) => {
			tableHtml +='<tr><td><input type="checkbox" class="selected" onclick="selected()"></td>'
			for(var obj in data)
			{
				tableHtml+='<td>'+data[obj]+'</td>'
			}
			tableHtml += '<td style="text-align: center;"><a href="/Home/Seedetails?booksid=' + data["id"]+'" style=" text-decoration: none;">查询详情</a></td></tr>'
							  
		})
	}
	/*tableHtml+=`</tbody></table>'
	<div class="container">'
	<button type="button" class="btn btn-primary dbutton">上一页</button>
	<span>3</span>/<span>3</span>
	<button type="button" class="btn btn-primary dbutton">下一页</button>
	<span>跳转到</span>
	<input type="text" style="width: 30px;">
	<span>页</span>
	<button type="button" class="btn btn-primary dbutton">GO</button>
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<span>共11本书</span> &nbsp;&nbsp;
	</div>`*/
	$(DOM).append(tableHtml);
}


function selected(){
	var all_checked = true;
	$(".selected").each(function(){
	    if(this.checked == false){
	        all_checked = false;
	    }
	});
	$(".cheAll").prop("checked",all_checked);
}
function ischeAll(){
	$(".selected").each(function(){
		$(this).prop("checked",$(".cheAll").prop('checked'));
	});
}


$(".del").click(function(){
	if(confirm("确定选中的内容删除吗？")){
		
	}
})
