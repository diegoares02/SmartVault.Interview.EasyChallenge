def twistedfizzbuzz(token_number, numbers)
  begin
    range = numbers.gsub(/[\(\)]/, '').split(' - ')
  rescue ArgumentError
    # Fallback: Split by comma if hyphen splitting fails
    range = numbers.gsub(/[\(\)]/, '').split(',')
  end
  if range.length > 2
    raise ArgumentError, "Invalid range format."
  end
  if range.length == 2
    start = range[0].to_i
    end_value = range[1].to_i
    (start...end_value).each do |i|
      result = ""
      token_number.each do |key, value|
        result << value if i % key == 0
      end
      puts i << "\n" if result.empty?
      puts result << "\n" unless result.empty?
    end
  else
    value = range[0].to_i
    result = ""
    token_number.each do |key, value|
      result << value if value % key == 0
    end
    puts value << "\n" if result.empty?
    puts result << "\n"
  end
end