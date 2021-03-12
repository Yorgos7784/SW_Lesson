<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    <%-- 
    선언문(declaration): <%! %> - 전역변수 느낌, 메쏘드 선언
    스크립틀릿(scriptlet): <% %> - 지역변수 느낌, 일반 루틴
    표현식(expression): <%= %> - 화면 출력(변수, 메쏘드 호출)
     --%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
	String str2 = "Yorgos";
	%>

	<%!
	String str = "전역 변수";
	%>
	
	<%!
	public String getStr(){
		return str;
	}
	%>
	
	<!-- HTML 주석 
	<h1>전역변수 : <%=str %></h1> 
	-->
	
	<%-- JSP 주석
	<h2>메쏘드호출 : <%=getStr() %></h2> 
	 --%>
	
	<h3>지역변수: <%=str2 %></h3>
</body>
</html>