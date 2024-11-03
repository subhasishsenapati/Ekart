import axios from "axios";

const api_url: string = "https://localhost:44313/api/User";

export const registerUserAPI = async (
  username: string,
  emailaddress: string,
  userpassword: string,
  isseller: boolean
) => {
  const url = `${api_url}/register`;
  var command = {
    userName: username,
    email: emailaddress,
    password: userpassword,
    isSeller: isseller,
  };
  const response = await axios
    .post(url, command)
    .catch((error) => console.error(error));

  return response;
};

export const loginUserAPI = async (username: string, userpassword: string) => {
  const url = `${api_url}/login`;
  var command = {
    userName: username,
    password: userpassword,
  };
  const response = await axios
    .post(url, command)
    .then((response) => {
      console.log(response);
    })
    .catch((error) => console.error(error));

  return response;
};
