<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" href="css/comm.css">
</head>
<body>
<%
request.setCharacterEncoding("UTF-8");

String id = request.getParameter("id");
String password = request.getParameter("pswd1");
String name = request.getParameter("name");
String[] gender = request.getParameterValues("gender");
String yy = request.getParameter("yy");
String[] mm = request.getParameterValues("mm");
String dd = request.getParameter("dd");
String email = request.getParameter("email");
String tel = request.getParameter("tel");


%>
<!-- wrapper -->
		<div id="wrapper">
			<!-- content-->
			<div id="content">
				<!-- ID -->
				<div>
					<h3 class="join_title">
						<label>아이디</label>
					</h3>
					<span class="box int_id"> 
						<%=id %>
					</span>
				</div>
				
				<!-- PW -->
				<div>
					<h3 class="join_title">
						<label>비밀번호</label>
					</h3>
					<span class="box int_id"> 
						<%=password %>
					</span>
				</div>
				
				<!-- NAME -->
				<div>
					<h3 class="join_title">
						<label>이름</label>
					</h3>
					<span class="box int_id"> 
						<%=name %>
					</span>
				</div>
				
				<!-- BIRTH -->
				<div>
					<h3 class="join_title">
						<label>생년월일</label>
					</h3>
					<span class="box int_id"> 
						<%=yy %>년 
                		<%
                    	for(String birthmm : mm){
                        	out.println(birthmm);
                    	}        
                		%>월 <%=dd %>일
					</span>
				</div>
				
				<!-- GENDER -->
				<div>
					<h3 class="join_title">
						<label>성별</label>
					</h3>
					<span class="box int_id"> 
						<%
							for(String gen : gender){
								out.println(gen);
							}
						%>
					</span>
				</div>
				
				<!-- EMAIN -->
				<div>
					<h3 class="join_title">
						<label>이메일</label>
					</h3>
					<span class="box int_id"> 
						<%=email %>
					</span>
				</div>
				
				<!-- TEL -->
				<div>
					<h3 class="join_title">
						<label>전화</label>
					</h3>
					<span class="box int_id"> 
						<%=tel %>
					</span>
				</div>
			</div>
			<!-- content-->
		</div>
</body>
</html>