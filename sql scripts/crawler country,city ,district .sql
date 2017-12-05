
declare @searchData nvarchar(MAX)
select @searchData = sHtml 
from HtmlImport
where Id =7

set @searchData = REPLACE(@searchData,'</optgroup>','|')
declare @fSPositon INT
declare @sSPositon INT
set @fSPositon = 0
set @sSPositon= 0
declare @inWhile INT
declare @inTag nvarchar(MAX)
declare @ln INT
set @inWhile= 1
while @inWhile = 1
begin
	set @fSPositon = CHARINDEX('<',@searchData)
		set @sSPositon = CHARINDEX('>',@searchData)
		if @fSPositon = 0 OR @sSPositon = 0
			SET @inWhile = 0
		else
		begin
			set @ln = @sSPositon - @fSPositon +1
			set @inTag = SUBSTRING(@searchData, @fSPositon,@ln)
			set @searchData = REPLACE(@searchData,@inTag,'')
		end	
end

insert into District(DistrictName,CityId)
select Element,2
from dbo.Split(@searchData,',')
--select @searchData

insert into HtmlImport(sHtml)
values
(
N'<optgroup label="Ăn uống">
<option value="12">Sang trọng</option>
<option value="39">Buffet</option>
<option value="1">Nhà hàng</option>
<option value="11">Ăn vặt/vỉa hè</option>
<option value="56">Ăn chay</option>
<option value="2">Café/Dessert</option>
<option value="3">Quán ăn</option>
<option value="4">Bar/Pub</option>
<option value="54">Quán nhậu</option>
<option value="43">Beer club</option>
<option value="6">Tiệm bánh</option>
<option value="44">Tiệc tận nơi</option>
<option value="27">Shop Online</option>
<option value="28">Giao cơm văn phòng</option>
<option value="79">Khu Ẩm Thực</option>
</optgroup>
<optgroup label="Du lịch">
<option value="7">Thăm quan &amp; chụp ảnh</option>
<option value="15">Khách sạn</option>
<option value="65">Khu nghỉ dưỡng</option>
<option value="66">Du lịch sinh thái</option>
<option value="63">Tàu du lịch</option>
<option value="24">Công viên vui chơi</option>
<option value="64">Bảo tàng &amp; Di tích</option>
<option value="16">Chùa &amp; Nhà thờ</option>
<option value="40">Phòng Vé Máy Bay</option>
<option value="74">Phương Tiện - Xe Cộ</option>
<option value="75">Homestay</option>
<option value="76">Căn hộ</option>
<option value="77">Nhà nghỉ</option>
<option value="78">Hãng Du Lịch</option>
</optgroup>
<optgroup label="Cưới hỏi">
<option value="9">Tiệc cưới/Hội nghị</option>
<option value="32">Chụp hình cưới</option>
<option value="33">Trang điểm</option>
<option value="34">Áo cưới</option>
<option value="35">Hoa cưới - Shop hoa</option>
<option value="36">Tiệc tại gia</option>
</optgroup>
<optgroup label="Đẹp khỏe">
<option value="14">Spa/Massage</option>
<option value="17">Làm tóc/Gội đầu/Nối mi</option>
<option value="18">Thể dục thẩm mỹ</option>
<option value="22">Tiệm nail</option>
<option value="42">Chăm sóc da</option>
<option value="41">Shop hóa mỹ phẩm</option>
<option value="26">Thể dục thể thao</option>
<option value="29">Thẩm mỹ viện</option>
<option value="37">Xăm hình</option>
<option value="19">Phòng khám</option>
<option value="20">Nha khoa</option>
<option value="21">Nhà thuốc</option>
<option value="38">Bệnh viện</option>
</optgroup>
<optgroup label="Giải trí">
<option value="5">Karaoke</option>
<option value="8">Billiards</option>
<option value="13">Rạp chiếu phim</option>
<option value="23">Sân khấu</option>
<option value="25">Khu chơi Game</option>
</optgroup>
<optgroup label="Mua sắm">
<option value="10">Shop/Cửa hàng</option>
<option value="30">Siêu thị</option>
<option value="31">Trung tâm thương mại</option>
<option value="67">Chợ</option>
<option value="70">Mua sắm Online</option>
</optgroup>
<optgroup label="Giáo dục">
<option value="46">Đại Học &amp; Cao Đẳng</option>
<option value="47">Trung tâm giáo dục</option>
<option value="48">Trung tâm ngoại ngữ</option>
<option value="49">Nhà sách &amp; Thư viện</option>
<option value="50">Nhà trẻ &amp; Mẫu giáo</option>
<option value="51">Trung học &amp; Phổ Thông</option>
<option value="52">Trường dạy nghề</option>
</optgroup>
<optgroup label="Dịch vụ">
<option value="57">Bank - ATM</option>
<option value="58">Trạm xăng</option>
<option value="59">Viễn thông</option>
<option value="60">Vận tải</option>
<option value="61">Giặt ủi</option>
<option value="62">Vật nuôi</option>
<option value="68">Trụ Sở Ban Ngành</option>
<option value="69">Trụ Sở Ban Ngành</option>
<option value="71">Dịch Vụ Vệ Sinh</option>
<option value="72">Dịch Vụ Sửa Chữa Nhà Cửa</option>
<option value="73">Dịch Vụ Vận Chuyển Đồ Đạc </option>
<option value="81">Cửa Hàng - Phụ Kiện</option>
</optgroup>'
)
