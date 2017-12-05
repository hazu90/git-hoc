
declare @searchData nvarchar(MAX)
select @searchData = sHtml 
from HtmlImport
where Id =7

SET @searchData = REPLACE(@searchData,'</optgroup>','|')
declare @lastGroupChar INT
declare @grStr nvarchar(MAX)
declare @tagGrOption nvarchar(MAX)
declare @inWhile BIT
declare @inWhile2 BIT
declare @fSP int
declare @sSP int
declare @p int
declare @ln int
declare @inTag nvarchar(MAX)
declare @grValue nvarchar(MAX)
declare @optValue nvarchar(MAX)
declare @iiId int
set @grValue = ''
set @fSP = 0
set @sSP = 0
SET @inWhile= 1

while @inWhile =1
begin
	set @lastGroupChar = CHARINDEX('|',@searchData)
	if @lastGroupChar <= 0
		set @inWhile = 0
	else
	begin 
		set @grStr = SUBSTRING(@searchData,1,@lastGroupChar )
		if @lastGroupChar >= LEN(@searchData)
			set @inWhile = 0
		else
		begin
			set @ln = LEN(@searchData)
			set @searchData = SUBSTRING(@searchData,@lastGroupChar+1 , @ln - @lastGroupChar)	
		end
			
		-- get optgroup
		set @fSP = CHARINDEX('<',@grStr)
		set @sSP = CHARINDEX('>',@grStr)
		set @tagGrOption = SUBSTRING(@grStr,1,@sSP)
		set @grStr = REPLACE(@grStr,@tagGrOption,'')
		set @grStr = REPLACE(@grStr,'|','')
		set @grStr = REPLACE(@grStr,'</option>',',')
		-- Get groption value
		set @p = CHARINDEX('"',@tagGrOption)
		set @ln = LEN(@tagGrOption)
		set @tagGrOption = SUBSTRING(@tagGrOption,@p+1 ,@ln -@p)
		set @p = CHARINDEX('"',@tagGrOption)
		if @grValue =''
			SET @grValue = SUBSTRING(@tagGrOption,1 ,@p-1)
		else
			SET @grValue += ','+SUBSTRING(@tagGrOption,1 ,@p-1)
		insert into CategoryGroup(CateName) 
		values(SUBSTRING(@tagGrOption,1 ,@p-1))
		set @iiId = SCOPE_IDENTITY()
		
		set @inWhile2 = 1
		while @inWhile2 = 1
		begin
			set @fSP = CHARINDEX('<',@grStr)
			set @sSP = CHARINDEX('>',@grStr)
			if @fSP = 0 OR @sSP = 0
				SET @inWhile2 = 0
			else
			begin
				set @ln = @sSP - @fSP +1
				set @inTag = SUBSTRING(@grStr, @fSP,@ln)
				set @grStr = REPLACE(@grStr,@inTag,'')
			end	
		end
		insert into Category(CateName,CateGrId)
		select Element,@iiId
		from dbo.Split(@grStr,',')
		--select @grStr
	end	
end
--select @grValue
