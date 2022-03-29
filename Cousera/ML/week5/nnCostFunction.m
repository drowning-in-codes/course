function [J grad] = nnCostFunction(nn_params, ...
                                   input_layer_size, ...
                                   hidden_layer_size, ...
                                   num_labels, ...
                                   X, y, lambda)
%NNCOSTFUNCTION Implements the neural network cost function for a two layer
%neural network which performs classification
%   [J grad] = NNCOSTFUNCTON(nn_params, hidden_layer_size, num_labels, ...
%   X, y, lambda) computes the cost and gradient of the neural network. The
%   parameters for the neural network are "unrolled" into the vector
%   nn_params and need to be converted back into the weight matrices. 
% 
%   The returned parameter grad should be a "unrolled" vector of the
%   partial derivatives of the neural network.
%

% Reshape nn_params back into the parameters Theta1 and Theta2, the weight matrices
% for our 2 layer neural network
Theta1 = reshape(nn_params(1:hidden_layer_size * (input_layer_size + 1)), ...
                 hidden_layer_size, (input_layer_size + 1));

Theta2 = reshape(nn_params((1 + (hidden_layer_size * (input_layer_size + 1))):end), ...
                 num_labels, (hidden_layer_size + 1));

% Setup some useful variables
m = size(X, 1);
       
% You need to return the following variables correctly 
J = 0;
Theta1_grad = zeros(size(Theta1));
Theta2_grad = zeros(size(Theta2));

% ====================== YOUR CODE HERE ======================
% Instructions: You should complete the code by working through the
%               following parts.
%
% Part 1: Feedforward the neural network and return the cost in the
%         variable J. After implementing Part 1, you can verify that your
%         cost function computation is correct by verifying the cost
%         computed in ex4.m
%
a_1 = [ones(1,m);X'];  %there is no z_1
z_2 = Theta1*a_1;
a_2 = [ones(1,m);sigmoid(z_2)]; %26*5000

z_3 = Theta2*a_2;
% Theta2 10*26 Theta1 25*401  (X';ones(1,m)) 401*5000  
h = sigmoid(z_3);
% h 10*5000;
  % transpose to get 5000examples with 10 features;
% h is the input feature through the forwardpropagation 

% y is 5000*1 imply that every example with 1-10 value


tr_y = zeros(m,num_labels);

%for i=1:m,
%  tr_y(i,y(i)) = 1;
%end

% I have to admit that I cant figure out how to do better without for-loop
% I just use for-loop to get a 5000*10 matrix

%upadte use sub2ind 
tr_y(sub2ind(size(tr_y),[1:m]',y)) = 1;

%1. 
% h = h';
% J = sum(sum(-tr_y.*log(h)-(1-tr_y).*log(1-h)))/m;

%2.
J = sum(diag(-tr_y*log(h)-(1-tr_y)*log(1-h)))/m;

% Part 2: Implement the backpropagation algorithm to compute the gradients
%         Theta1_grad and Theta2_grad. You should return the partial derivatives of
%         the cost function with respect to Theta1 and Theta2 in Theta1_grad and
%         Theta2_grad, respectively. After implementing Part 2, you can check
%         that your implementation is correct by running checkNNGradients
%
%         Note: The vector y passed into the function is a vector of labels
%               containing values from 1..K. You need to map this vector into a 
%               binary vector of 1's and 0's to be used with the neural network
%               cost function.
%
%         Hint: We recommend implementing backpropagation using a for-loop
%               over the training examples if you are implementing it for the 
%               first time.
%

%  hidden_layer  output_layer
%   a1 compute(z2 z3 a2 a3);
a_3 = h;  %10*5000

delta_3 = a_3-tr_y'; % 10*5000

% Theta2 10*26 Theta1 25*401  z_2 25*5000
delta_2 = Theta2'(2:end,:)*delta_3.*sigmoidGradient(z_2);

% a_2 26*5000
% delta_3 10*5000
Theta2_grad = (delta_3*a_2')./m;  %10*26
% delta_2 25*5000
Theta1_grad = (delta_2*a_1')./m;   %25*401

% Part 3: Implement regularization with the cost function and gradients.
%
%         Hint: You can implement this around the code for
%               backpropagation. That is, you can compute the gradients for
%               the regularization separately and then add them to Theta1_grad
%               and Theta2_grad from Part 2.
%

J = J+lambda/2/m*sum([Theta1(:,2:end)(:);Theta2(:,2:end)(:)].**2);

temp1 = Theta1;
temp1(:,1) = 0;
Theta1_grad = Theta1_grad+(lambda/m).*temp1;


%Theta1_grad(:,2:end) += (lambda/m).*Theta1(:,2:end);

Theta2_grad(:,2:end) += (lambda/m).*Theta2(:,2:end);

















% -------------------------------------------------------------

% =========================================================================

% Unroll gradients
grad = [Theta1_grad(:) ; Theta2_grad(:)];


end
